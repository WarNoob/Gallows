using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Gallows;

namespace ItitFrame.Test
{
    class MyFormCollection : FormCollection
    {
        public void Add(Form form)
        {
            InnerList.Add(form);
        }
        public void Remove(Form form)
        {
            InnerList.Remove(form);
        }
    }
    [TestClass]
    public class InitFrameTest
    {
        [TestMethod]
        public void InitFrame_StartGame_2OpenWindos()
        {
            InitFrame init = new InitFrame();
            MyFormCollection formColl = new MyFormCollection();
            formColl.Add(init);

            GameFrame game = init.StartGame(formColl);
            formColl.Add(game);
            Form[] expected = new Form[] { init, game };
            CollectionAssert.AreEqual(expected, formColl);
        }
        [TestMethod]
        public void InitFrame_StartGame_More2OpenWindos()
        {
            InitFrame init = new InitFrame();
            MyFormCollection formColl = new MyFormCollection();
            formColl.Add(init);

            GameFrame game1 = init.StartGame(formColl);
            formColl.Add(game1);
            GameFrame game2 = init.StartGame(formColl);
            formColl.Add(game2);
            formColl.Remove(game1);
            Form[] expected = new Form[] { init, game2 };
            CollectionAssert.AreEqual(expected, formColl);
        }
    }
}
