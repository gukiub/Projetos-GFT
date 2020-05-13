package com.example.learning.basic

interface Maquina1{

    fun ligar()
    fun desligar() {
        println("Off")
    }
}

class Computador1() : Maquina1 {
    override fun ligar(){

    }
}

interface interface1{
    fun ola() {
        println("Interface 1")
    }
}

interface interface2  {
    fun ola() {
        println("Interface 2")
    }
}

class ImplementaInterface : interface1,
    interface2 {
    override fun ola() {
        super<interface2>.ola()
    }

}

fun main(){
    val teste = ImplementaInterface()
    teste.ola()
}