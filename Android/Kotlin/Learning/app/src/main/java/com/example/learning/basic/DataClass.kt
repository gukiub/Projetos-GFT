package com.example.learning.basic

class Quadrado(val area: Float){

}

data class Triangulo(val area:Float)


fun main(){

    val ql = Quadrado(10f)
    val q2 = Quadrado(10f)

    val t1 = Triangulo(10f)
    val t2 = Triangulo(10f)


    val t3 = t2.copy()
    println(t3)

}