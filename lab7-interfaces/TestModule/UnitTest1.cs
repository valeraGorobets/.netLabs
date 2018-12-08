using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab7_interfaces;

namespace TestModule
{
    [TestClass]
    public class UnitTestDrawingNotebookClass
    {
        const int drawingNotebookAmountOfPages = 10;
        DrawingNotebook drawingNotebook = new DrawingNotebook(drawingNotebookAmountOfPages);

        [TestMethod]
        public void TestNotebookPageAmount()
        {
            Assert.AreEqual(drawingNotebook.pageAmount, drawingNotebookAmountOfPages);
        }

        [TestMethod]
        public void TestNotebookBuring()
        {
            drawingNotebook.Burn(500);
            Assert.AreEqual(drawingNotebook.pageAmount, 0);
        }

        [TestMethod]
        public void TestNotebookNotBuring()
        {
            drawingNotebook.Burn(100);
            Assert.AreEqual(drawingNotebook.pageAmount, drawingNotebookAmountOfPages);
        }

        [TestMethod]
        public void TestNotebookImage()
        {
            Image image = new Image();
            image.AddPixel(new Pixel(0, 0, "red"));
            image.AddPixel(new Pixel(1, 1, "red"));
            image.AddPixel(new Pixel(2, 2, "red"));
            image.AddPixel(new Pixel(3, 3, "red"));
            image.AddPixel(new Pixel(4, 4, "red"));
            drawingNotebook.WriteOnMe(image);

            Image image2 = new Image();
            image2.AddPixel(new Pixel(0, 1, "blue"));
            image2.AddPixel(new Pixel(1, 2, "blue"));
            image2.AddPixel(new Pixel(2, 3, "blue"));
            image2.AddPixel(new Pixel(3, 4, "blue"));
            image2.AddPixel(new Pixel(4, 5, "blue"));
            drawingNotebook.WriteOnMe(image2);

            Assert.AreEqual(drawingNotebook.images.Count, 2);
        }
    }

    [TestClass]
    public class UnitTestExercisebookClass
    {
        const int exercisebookAmountOfPages = 10;
        Exercisebook exercisebook = new Exercisebook(exercisebookAmountOfPages, "Math");

        [TestMethod]
        public void TestExercisebookWritingMethod()
        {
            exercisebook.WriteOnMe("Hello");
            exercisebook.WriteOnMe("World");
            exercisebook.WriteOnMe("This");
            exercisebook.WriteOnMe("Is");
            exercisebook.WriteOnMe("Me!");
            Assert.AreEqual(exercisebook.uniqueParagraphs.Count, 5);
        }

        [TestMethod]
        public void TestExercisebookPlagiarismMethod()
        {
            exercisebook.WriteOnMe("Hello");
            exercisebook.WriteOnMe("World");
            exercisebook.WriteOnMe("This");
            exercisebook.WriteOnMe("Is");
            exercisebook.WriteOnMe("Me!");
            Assert.IsTrue(exercisebook.IsPlagiarismPassed("WOO"));
        }

        [TestMethod]
        public void TestExercisebookPlagiarismFailingMethod()
        {
            exercisebook.WriteOnMe("Hello");
            exercisebook.WriteOnMe("World");
            exercisebook.WriteOnMe("This");
            exercisebook.WriteOnMe("Is");
            exercisebook.WriteOnMe("Me!");
            Assert.IsFalse(exercisebook.IsPlagiarismPassed("This"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            Exercisebook.ExeptionMessage)]
        public void TestExercisebookWritingMethodThrowsErrorOnDuplicate()
        {
            exercisebook.WriteOnMe("Hello");
            exercisebook.WriteOnMe("Duplicate");
            exercisebook.WriteOnMe("This");
            exercisebook.WriteOnMe("Is");
            exercisebook.WriteOnMe("Duplicate");
            exercisebook.WriteOnMe("!");
        }
    }
}
