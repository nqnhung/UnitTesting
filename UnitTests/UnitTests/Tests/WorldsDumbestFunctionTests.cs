using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnPikachuIfzero_ReturnString()
        {
			try
			{
				//Arrange
				int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act
                string result = worldsDumbest.ReturnPikachuIfZero(num);

                //Assert
                if (result == "PIKACHU")
                    Console.WriteLine("PASSED: WorldDumbestFunction_ReturnPikachuIfzero_ReturnString");
                else
                    Console.WriteLine("FAILED");
            }
			catch (Exception ex)
			{

				throw new Exception($"{ex}");
			}
        }
    }
}
