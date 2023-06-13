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
            //���� �������� �������� �������
            var obj = new RoadWork(10, 50, 20);
            Assert.AreEqual(10, obj.GetQuality());
        }
       
        [Test]
        public void ChildQualityCaseOne()
        {
            //���� �������� �������-������� � ������� P=5
            var obj = new RoadWorksChild(10, 50, 20, 5);
            Assert.AreEqual(11, obj.GetQuality());
        }
        [Test]
        public void ChildQualityCaseTwo ()
        {
            //���� �������� �������-������� � ������� P=3
            var obj = new RoadWorksChild(10, 50, 20, 3);
            Assert.AreEqual(16, obj.GetQuality());
        }
        [Test]
        public void ChildQualityWithWrongPower ()
        {
            //���� �������� �������-������� � ������������ ��������� ������������ ���������
            Assert.Throws<ArgumentException>(() => new RoadWorksChild(10, 50, 20, 0));
        }
    }
}