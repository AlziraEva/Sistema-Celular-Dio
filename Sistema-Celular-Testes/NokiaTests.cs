using DesafioPOO.Models;

namespace Sistema_Celular_Testes;

public class NokiaTests
{
    // Arrange
    Nokia nokia = new Nokia("81 9999-8888", "J5", 6, 32, "Nokia");

    [Fact]
    public void InstalarAplicativoComMemoriaSuficiente()
    {
        Assert.True(nokia.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComMemoriaInsuficiente()
    {
        Nokia nokia2 = new Nokia("81 9999-8888", "J5", 6, 1, "Iphone");

        Assert.False(nokia2.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComNomeIgual()
    {
        nokia.InstalarAplicativo("Zap");

        Assert.False(nokia.InstalarAplicativo("Zap"));

    }

}
