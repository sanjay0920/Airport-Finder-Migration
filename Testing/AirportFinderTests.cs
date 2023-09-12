using airport_finder.Models;
using airport_finder.Repository;
using airport_finder.Services;
using airport_finder.Services.Implementation;
using Moq;
using System.Runtime.InteropServices;

namespace Testing
{
    public class AirportFinderTests
    {
        private readonly Mock<IAirportService> _airportService;

        private readonly Mock<ICityService> _cityService;

        private readonly Mock<IRepository<AirportInfo>> _airrepo;

        public AirportFinderTests()

        {

            _airportService = new Mock<IAirportService>();

            _cityService = new Mock<ICityService>();

            _airrepo = new Mock<IRepository<AirportInfo>>();

        }



        [Fact]

        public void AirportListTest_Should_Return_Success()

        {



            //Arrange

            _airrepo.Setup(x => x.Get()).Returns(GetAirportsList());

            _cityService.Setup(x => x.Get()).Returns(GetCityInfoList());



            //Act

            AirportServices list = new AirportServices(_airrepo.Object, _cityService.Object);


            var k = list.Get();



            //Assert

            Assert.True(k.Count() > 0);

        }

        [Theory]
        [InlineData("TamilNadu")]
        public void GetAirportsByState(string id)
        {
            //Arrange
            _airrepo.Setup(x => x.Get()).Returns(GetAirportsList());
            _cityService.Setup(x => x.Get()).Returns(GetCityInfoList());
            //Act
            AirportServices list = new AirportServices(_airrepo.Object, _cityService.Object);



            var k = list.GetAirportsByState(id);



            //Assert
            Assert.True(k.Count() > 0);
        }



        private List<AirportInfo> GetAirportsList()
        {
            return new List<AirportInfo>
            {
                new AirportInfo(){ AirportName="Chennai International Airport", City="Chennai",IataCode="MAA",State="TamilNadu"},
                new AirportInfo(){ AirportName="Coimbatore International Airport", City="Coimbatore",IataCode="CJB",State="TamilNadu"},
                new AirportInfo(){AirportName="Madurai Airport",City="Madurai",IataCode="IXM",State="TamilNadu"},
                new AirportInfo(){AirportName="Kovilpatti Airport",City="Nallatinputhur",IataCode="KPI",State="TamilNadu"},
                new AirportInfo(){AirportName="Neyveli Airport",City="Neyveli",IataCode="NVY",State="TamilNadu"},
                new AirportInfo(){AirportName="Tiruchirappalli International Airport",City="Tiruchirappalli",IataCode="TRZ",State="TamilNadu"}



            };
        }


       

       
        private List<CityInfo> GetCityInfoList()
        {
            return new List<CityInfo> {
            new CityInfo(){ City="Chennai",Lat=13.0836939,Long=80.270186 },
            new CityInfo(){ City="Salem",Lat=11.65212,Long=78.157982 }
            };
        }
    }
}