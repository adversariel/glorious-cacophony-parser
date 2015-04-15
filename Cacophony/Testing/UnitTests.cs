using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cacophony;

namespace Testing
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod()]
        public void TestPosToFreq()
        {
            int c = Noises.PositionToFreq(40);
            Assert.AreEqual(261, c);
        }
        
        [TestMethod()]
        public void TestNoteToPos()
        {
            int posA0 = Noises.NameToPosition("A0");
            int posA1 = Noises.NameToPosition("A1");
            int posB1 = Noises.NameToPosition("B1");
            int posC2 = Noises.NameToPosition("C2");
            int posD3 = Noises.NameToPosition("D3");
            int posG6 = Noises.NameToPosition("G6");
            int posB7 = Noises.NameToPosition("B7");
            Assert.AreEqual(1, posA0);
            Assert.AreEqual(13, posA1);
            Assert.AreEqual(15, posB1);
            Assert.AreEqual(16, posC2);
            Assert.AreEqual(30, posD3);
            Assert.AreEqual(71, posG6);
            Assert.AreEqual(87, posB7);
        }

        [TestMethod()]
        public void TestAtoPos()
        {
            int posA0 = Noises.NameToPosition("A0");
            int posA1 = Noises.NameToPosition("A1");
            int posA2 = Noises.NameToPosition("A2");
            int posA3 = Noises.NameToPosition("A3");
            int posA4 = Noises.NameToPosition("A4");
            int posA5 = Noises.NameToPosition("A5");
            int posA6 = Noises.NameToPosition("A6");
            int posA7 = Noises.NameToPosition("A7");
            Assert.AreEqual(1, posA0);
            Assert.AreEqual(13, posA1);
            Assert.AreEqual(25, posA2);
            Assert.AreEqual(37, posA3);
            Assert.AreEqual(49, posA4);
            Assert.AreEqual(61, posA5);
            Assert.AreEqual(73, posA6);
            Assert.AreEqual(85, posA7);
        }

        [TestMethod()]
        public void TestBtoPos()
        {
            int pos0 = Noises.NameToPosition("B0");
            int pos1 = Noises.NameToPosition("B1");
            int pos2 = Noises.NameToPosition("B2");
            int pos3 = Noises.NameToPosition("B3");
            int pos4 = Noises.NameToPosition("B4");
            int pos5 = Noises.NameToPosition("B5");
            int pos6 = Noises.NameToPosition("B6");
            int pos7 = Noises.NameToPosition("B7");
            Assert.AreEqual(3, pos0);
            Assert.AreEqual(15, pos1);
            Assert.AreEqual(27, pos2);
            Assert.AreEqual(39, pos3);
            Assert.AreEqual(51, pos4);
            Assert.AreEqual(63, pos5);
            Assert.AreEqual(75, pos6);
            Assert.AreEqual(87, pos7);
        }

        [TestMethod()]
        public void TestCtoPos()
        {
            int pos1 = Noises.NameToPosition("C1");
            int pos2 = Noises.NameToPosition("C2");
            int pos3 = Noises.NameToPosition("C3");
            int pos4 = Noises.NameToPosition("C4");
            int pos5 = Noises.NameToPosition("C5");
            int pos6 = Noises.NameToPosition("C6");
            int pos7 = Noises.NameToPosition("C7");
            int pos8 = Noises.NameToPosition("C8");
            Assert.AreEqual(4, pos1);
            Assert.AreEqual(16, pos2);
            Assert.AreEqual(28, pos3);
            Assert.AreEqual(40, pos4);
            Assert.AreEqual(52, pos5);
            Assert.AreEqual(64, pos6);
            Assert.AreEqual(76, pos7);
            Assert.AreEqual(76, pos7);
            Assert.AreEqual(88, pos8);
        }

        [TestMethod()]
        public void TestDtoPos()
        {
            int pos1 = Noises.NameToPosition("D1");
            int pos2 = Noises.NameToPosition("D2");
            int pos3 = Noises.NameToPosition("D3");
            int pos4 = Noises.NameToPosition("D4");
            int pos5 = Noises.NameToPosition("D5");
            int pos6 = Noises.NameToPosition("D6");
            int pos7 = Noises.NameToPosition("D7");
            Assert.AreEqual(6, pos1);
            Assert.AreEqual(18, pos2);
            Assert.AreEqual(30, pos3);
            Assert.AreEqual(42, pos4);
            Assert.AreEqual(54, pos5);
            Assert.AreEqual(66, pos6);
            Assert.AreEqual(78, pos7);
        }

        [TestMethod()]
        public void TestAccToPos()
        {
            int pos1 = Noises.NameToPosition("A#0");
            int pos2 = Noises.NameToPosition("C#1");
            int pos3 = Noises.NameToPosition("Db1");
            int pos4 = Noises.NameToPosition("F#1");
            int pos5 = Noises.NameToPosition("Bb1");
            int pos6 = Noises.NameToPosition("A#2");
            int pos7 = Noises.NameToPosition("Gb6");
            int pos8 = Noises.NameToPosition("G#6");
            Assert.AreEqual(2, pos1);
            Assert.AreEqual(5, pos2);
            Assert.AreEqual(5, pos3);
            Assert.AreEqual(10, pos4);
            Assert.AreEqual(14, pos5);
            Assert.AreEqual(26, pos6);
            Assert.AreEqual(70, pos7);
            Assert.AreEqual(72, pos8);
        }

        [TestMethod()]
        public void TestNoteDur()
        {
            double quarter = Noises.NoteValToDur(4, 120);
            double half = Noises.NoteValToDur(2, 120);
            double whole = Noises.NoteValToDur(1, 120);
            double eighth = Noises.NoteValToDur(8, 120);
            double sixteenth = Noises.NoteValToDur(16, 120);
            Assert.AreEqual(500, quarter);
            Assert.AreEqual(1000, half);
            Assert.AreEqual(2000, whole);
            Assert.AreEqual(250, eighth);
            Assert.AreEqual(125, sixteenth);
        }
    }
}
