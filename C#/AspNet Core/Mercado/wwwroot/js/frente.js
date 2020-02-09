var enderecoProduto = "https://localhost:5001/Produto/Produto/";
var produto;
var compra = [];

function preencherFormulario(dadosProduto){
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome);
    $("#campoFornecedor").val(dadosProduto.fornecedor.nome);
    $("#campoPreco").val(dadosProduto.precoDeVenda);
}


function zerarFormulario(){
    $("#campoNome").val("");
    $("#campoCategoria").val("");
    $("#campoFornecedor").val("");
    $("#campoPreco").val("");
    $("#campoQuantidade").val("");
}


function adicionarNaTabela(p,q){
    
    var produtoTemp = {};
    Object.assign(produtoTemp, produto);
    compra.push(produtoTemp);

    $("#compras").append(`<tr>
        <td>${p.id}</td>
        <td>${p.nome}</td>
        <td>${q}</td>
        <td>${p.precoDeVenda}</td>
        <td>${p.medicao}</td>
        <td>${p.precoDeVenda * q} R$</td>
        <td><button class='btn btn-danger'>remover</button></td>
    </tr>`);
}

$("#produtoForm").on("submit", function(event){
    event.preventDefault();
    var produtoParaTabela = produto;
    var qtd = $("#campoQuantidade").val();
    adicionarNaTabela(produtoParaTabela, qtd);
    console.log(produtoParaTabela);
    console.log(qtd);
    //var produto = undefined;
    //zerarFormulario();
});

$("#pesquisar").click(function(){
    var codProduto = $("#codProduto").val();
    var enderecoTmporario  = enderecoProduto + codProduto;
    $.post(enderecoTmporario, function(dados, status){
            produto = dados;
            switch(produto.medicao){
                case 0:
                    med = "L" 
                    break;
                case 1:
                    med = "K";
                    break;
                case 2:
                    med = "U";
                    break;
                default:
                    med = "U"
                    break;
            }
            produto.medicao = med;
            preencherFormulario(produto);
    }).fail(function(){
        alert("produto inválido");
    });
});