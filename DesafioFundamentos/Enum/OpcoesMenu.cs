using System.ComponentModel;

namespace DesafioFundamentos.Enum;

public enum OpcoesMenu : byte
{
    [Description("Cadastrar Veículo")]
    CadastrarVeiculo = 1,

    [Description("Remover Veículo")]
    RemoverVeiculo = 2,

    [Description("Listar Veículo")]
    ListarVeiculos = 3,

    [Description("Encerrar")]
    Encerrar = 4
}
