using NUnit.Framework;
using CalcularorAPP;
namespace CalculatorAppTest;
using Moq;

[TestFixture]
public class Tests
{
    public static Icalculator Iobj;
    public static IEmp Iempobj;
    public static Mock<Icalculator> mockcalc;
    [SetUp]
    public void Setup()
    {
        Iobj = new Calculator();
        Iempobj = new Emp();
        mockcalc = new Mock<Icalculator>();
    }

    [Test]
    public void TestGetAllEmpsCount()
    {
        var actualresult = Iempobj.getAllEmployees();
        int count =actualresult.Count;
        int expectedCount = 2;
        Assert.AreEqual(expectedCount, count);
    }

    [Test]
    public void TestGetAllEmpsEname()
    {
        List<Emp> actualresult = Iempobj.getAllEmployees();
        Emp obj = new Emp();
        foreach (var item in actualresult)
        {
            obj.Ename = item.Ename;
            obj.Eid = item.Eid;
            obj.Sal = item.Sal;

        }
        float expectedSalary = 12000;
        Assert.AreEqual(expectedSalary,obj.Sal);
    }

    [Test]
    public void TestAdd()
    {
        //Asume act Assert
        int actualresult=Iobj.add(10, 5);
        int expectedresult=15;
        Assert.AreEqual(expectedresult, actualresult);
        
    }

    [Test]
    public void TestSub()
    {
        int actualresult = Iobj.sub(10, 5);
        int expectedresult = 5;
        Assert.AreEqual(expectedresult, actualresult);
    }

    [Test]
    public void TestMessage()
    {
        string actualresult = Iobj.Message("Ram");
        string expectedresult = "Hello Ram";
        Assert.AreEqual(expectedresult, actualresult);
    }

    [Test]
    public void TestCheckAgePass()
    {
        bool actualresult = Iobj.checkage(22);
        bool expectedresult = true;
        Assert.AreEqual( expectedresult,actualresult);
    }

    [Test]
    public void TestCheckAgeFail()
    {
        bool actualresult = Iobj.checkage(12);
        bool expectedresult = false;
        Assert.AreEqual(expectedresult, actualresult);
    }

    [Test]
    public void testValidData()
    {
        mockcalc.Setup(x => x.checkage(19)).Returns(true);
        int actres = Iobj.validData();
        int expected = 10;
        Assert.AreEqual(expected, actres);
    }
}