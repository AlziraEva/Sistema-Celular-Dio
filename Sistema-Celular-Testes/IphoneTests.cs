using DesafioPOO.Models;

namespace Sistema_Celular_Testes;

public class IphoneTests
{

    // Arrange
    Iphone iphone = new Iphone("81 9999-8888", "J5", 6, 32, "Iphone");

    [Fact]
    public void RealizarChamadaSemEstaEmOutraLigacao()
    {

        // Act e Assert
        Assert.True(iphone.Ligar());

    }


    [Fact]
    public void NaoLigarQuandoEstaEmOutraChamada()
    {

        iphone.Ligar();

        Assert.False(iphone.Ligar());

    }

    [Fact]
    public void DesligarLigacaoComChamadaLigada()
    {
        iphone.Ligar();

        Assert.True(iphone.Desligar());

    }

    [Fact]
    public void NaoDesligarNovamenteQuandoChamadaJaDesligada()
    {
        iphone.Desligar();

        Assert.False(iphone.Desligar());

    }

    [Fact]
    public void InstalarAplicativoComMemoriaSuficiente()
    {
        Assert.True(iphone.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComMemoriaInsuficiente()
    {
        Iphone iphone2 = new Iphone("81 9999-8888", "J5", 6, 0, "Iphone");

        Assert.False(iphone2.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComNomeIgual()
    {
        iphone.InstalarAplicativo("Zap");

        Assert.False(iphone.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void DesistalarAplicativoQueExisteNaLista()
    {
        iphone.InstalarAplicativo("Zap");

        Assert.True(iphone.DesistalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoDesistalarAplicativoQueNaoExisteNaLista()
    {

        Assert.False(iphone.DesistalarAplicativo("Zap"));

    }
}
