using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Robostore.Models
{
    public class MockRobotRepository: iRobotRepository
    {
        private readonly iCategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Robot> Robots
		{
			get
			{
                return new List<Robot>
                {
                    new Robot {RobotId = 1, Name="Omni Robot", Price=10, ShortDescription="Робот на Колесах Омни", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsRobotOfTheWeek=false, ImageThumbnailUrl="https://ae01.alicdn.com/kf/HTB1ri7fIVXXXXXrXFXXq6xXFXXXr/3WD-48-мм-font-b-omni-b-font-колеса-Робота-Шасси-Автомобиля-для-Arduino-15001.jpg"},
					new Robot {RobotId = 2, Name="Spider Robot", Price=15, ShortDescription="Паукообразный робот", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.", Category = _categoryRepository.Categories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsRobotOfTheWeek=false, ImageThumbnailUrl="http://labpeers.com/php-file-download-script/download.php?filename=../media/catalog/product/3/_/3_2_1.jpg"},
                    new Robot {RobotId = 3, Name="Zumo Robot", Price=18, ShortDescription="Гусеничный робот", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, IsRobotOfTheWeek=true, ImageThumbnailUrl="http://www.smartarduino.com/upfiles/card/20150816/14396915275910.jpg"},
                    new Robot {RobotId = 4, Name="Walking Robot", Price=20, ShortDescription="Шагающий робот", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.", Category = _categoryRepository.Categories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsRobotOfTheWeek=true, ImageThumbnailUrl="http://www.robotshop.com/media/catalog/product/cache/1/image/800x800/9df78eab33525d08d6e5fb8d27136e95/l/y/lynxmotion-biped-robot-scout-bps-ns-servos_1.jpg"}
				};
			}
		}

		public IEnumerable<Robot> RobotsOfTheWeek { get; }
		public Robot GetRobotById(int RobotId)
		{
			throw new System.NotImplementedException();
		}
	}
}
