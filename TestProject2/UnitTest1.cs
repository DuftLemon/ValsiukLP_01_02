using ValsiukLP_01_02;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void BasicQuality ()
        {
            //тест базового качества объекта
            var obj = new RoadWork(10, 50, 20);
            Assert.AreEqual(10, obj.GetQuality());
        }
       
        [Test]
        public void ChildQualityCaseOne()
        {
            //тест качества объекта-потомка в условии P=5
            var obj = new RoadWorksChild(10, 50, 20, 5);
            Assert.AreEqual(11, obj.GetQuality());
        }
        [Test]
        public void ChildQualityCaseTwo ()
        {
            //тест качества объекта-потомка в условии P=3
            var obj = new RoadWorksChild(10, 50, 20, 3);
            Assert.AreEqual(16, obj.GetQuality());
        }
        [Test]
        public void ChildQualityWithWrongPower ()
        {
            //тест качества объекта-потомка с некорректным значением коэффициента прочности
            Assert.Throws<ArgumentException>(() => new RoadWorksChild(10, 50, 20, 0));
        }
    }
}