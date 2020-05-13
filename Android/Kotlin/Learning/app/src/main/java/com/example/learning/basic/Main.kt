package com.example.learning.basic

open class Maquina (val marca: String){
    open fun minhaMarca(){
        println("minha marca é $marca")
    }
}

class Computador(marca: String, val nucleos: Int) : Maquina(marca){

    override fun minhaMarca() {
        super.minhaMarca()
        println("Estou reescrevendo minha marca")
    }

    fun ligar(){}
    fun processar(){}

    fun overload(i: Int) = println("Overload 1")
    fun overload(i:Int, s: String) = println("Overload 2")
    fun overload(i:Int, b: Boolean) = println("Overload 3")

    private fun validate(){

    }

}


class Constants private constructor(){
    companion object BANCO{
        val TABLE = "Pessoa"

        fun teste() {
            println("Sou um método estático.")
        }
    }

    object VENDAS{
        val TABLE_NAME = "Vendas"

        object COLUNAS{
            val ID = "Id"
            val TOTAL = "Total"
        }
    }
}

fun main(){
    val c: Computador =
        Computador("xpto", 10)
    with(c){
        ligar()
        processar()
        minhaMarca()
        overload(10, "")
        overload(10)
        overload(10, false)
    }

    println(Constants.TABLE)
    Constants.teste()

    Constants.TABLE
    Constants.teste()

    Constants.VENDAS.COLUNAS.TOTAL
}