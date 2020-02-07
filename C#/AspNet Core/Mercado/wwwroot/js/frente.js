var enderecoProduto = "https://localhost:5001/Produto/Produto/";
var produto;


function preencherFormulario(dadosProduto){
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome);
    $("#campoFornecedor").val(dadosProduto.fornecedor.nome);
    $("#campoPreco").val(dadosProduto.precoDeVenda);
}


$("#pesquisar").click(function(){
    var codProduto = $("#codProduto").val();
    var enderecoTmporario  = enderecoProduto + codProduto;
    $.post(enderecoTmporario, function(dados, status){
            produto = dados;
            preencherFormulario(produto);
    }).fail(function(){
        alert("produto inválido");
    });
});