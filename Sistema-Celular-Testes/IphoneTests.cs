using DesafioPOO.Models;

namespace Sistema_Celular_Testes;

public class IphoneTests
{

    // Arrange
    Iphone iphone = new Iphone("81 9999-8888", "J5", 6, 32, "Iphone");

    [Fact]
    public void RealizarChamadaSemEstaEmOutraLigacaoRetornarTrue()
    {

        // Act e Assert
        Assert.True(iphone.Ligar());

    }


    [Fact]
    public void NaoLigarQuandoEstaEmOutraChamadaChamarMetodoLigar2VezesERetornarFalse()
    {

        iphone.Ligar();

        Assert.False(iphone.Ligar());

    }

    [Fact]
    public void DesligarLigacaoEmChamadaLigadaChamarMetodoLigarEMetodoDesligarRetornarTrue()
    {
        iphone.Ligar();

        Assert.True(iphone.Desligar());

    }

    [Fact]
    public void NaoDesligarNovamenteQuandoChamadaDesligadaChamarMetodoDesligar2VezesERetornarFalse()
    {
        iphone.Desligar();

        Assert.False(iphone.Desligar());

    }

    [Fact]
    public void InstalarAplicativoComMemoriaInternaIgualHa32RetornarTrue()
    {
        Assert.True(iphone.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComMemoriaInternaIgualHa1RetornarFalse()
    {
        Iphone iphone2 = new Iphone("81 9999-8888", "J5", 6, 1, "Iphone");

        Assert.False(iphone2.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoInstalarAplicadoComNomesIguaisChamarMetodoInstalarAplicativoComParametrosIguaisERetornarFalse()
    {
        iphone.InstalarAplicativo("Zap");

        Assert.False(iphone.InstalarAplicativo("Zap"));

    }

    [Fact]
    public void DesistalarAplicativoQueExisteNaListaChamarMetodoInstalarAplicativoEChamarMetodoDesistalarAplicativoComMesmoParametroERetornarTrue()
    {
        iphone.InstalarAplicativo("Zap");

        Assert.True(iphone.DesistalarAplicativo("Zap"));

    }

    [Fact]
    public void NaoDesistalarAplicativoQueNaoExisteNaListaChamarMetodoDesistalarAplicativoComParametroQueNaoExisteNaListaERetornarFalse()
    {

        Assert.False(iphone.DesistalarAplicativo("Zap"));

    }
}
