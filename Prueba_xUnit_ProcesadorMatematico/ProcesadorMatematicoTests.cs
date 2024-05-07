using primer_parcial_unit_test_procesador_matematico;

namespace Prueba_xUnit_ProcesadorMatematico
{
    public class ProcesadorMatematicoTests
    {
        [Fact]
        public void Sumar_DeberiaSumarCorrectamente()
        {
            // Arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();

            // Act
            procesador.Sumar(5, 3); // Sumo 

            // Assert
            Assert.Equal(8, procesador.GetResultado()); // Si da 8 es correcto y paso
        }

        [Fact]
        public void Dividir_DeberiaDividirCorrectamente()
        {
            // Arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();

            // Act
            procesador.Dividir(10, 2);

            // Assert
            Assert.Equal(5, procesador.GetResultado());
        }

        [Fact]
        public void CalcularMayor_DeberiaCalcularMayorCorrectamente()
        {
            // Arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();

            // Act
            procesador.CalcularMayor(7, 12);

            // Assert
            Assert.Equal(12, procesador.GetResultado());
        }
    }
}