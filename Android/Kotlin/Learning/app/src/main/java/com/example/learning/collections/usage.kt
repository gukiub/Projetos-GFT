package com.example.learning.collections

data class Food(
    val name: String,
    val calories: Double,
    val ingredients: List<Ingredients> = listOf()
)

data class Ingredients(val name: String, val quantity: Int)

fun hasIngredient(list: List<Ingredients>, name: String ): Boolean{
   return list.filter { it.name == name }.any()

}

fun main(args: Array<String>) {

    val data = listOf(
        Food(
            "Lasanha", 1200.0,
            listOf(
                Ingredients("Farinha", 1),
                Ingredients("Presunto", 5),
                Ingredients("Queijo", 10),
                Ingredients("Molho de tomate", 2),
                Ingredients("Manjerição", 3)
            )
        ),
        Food("Panqueca", 500.0),
        Food("Omelete", 200.0),
        Food("Parmegiana", 700.0),
        Food("Sopa de feijão", 300.0),
        Food(
            "Hamburguer", 2000.0,
            listOf(
                Ingredients("Pão", 1),
                Ingredients("Hamburguer", 3),
                Ingredients("Queijo", 1),
                Ingredients("Catupiry", 1),
                Ingredients("Bacon", 3),
                Ingredients("Alface", 1),
                Ingredients("Tomate", 1)
            )
        )
    )

    // Tenho receitas na lista?
    println("Tenho receitas? ${if (data.any()) "sim" else "não"}.")

    // Quantas receitas tenho na coleção?
    println("Tenha ${data.count()} receitas.")

    // Qual a primeira e ultima receita?
    println("A primeira receita é: ${data.first().name}.")
    println("A última receita é: ${data.last().name}.")

    // Qual a soma de calorias?
    //    var sum: Int = 0
    //    for(x in data){
    //        sum = sum + x.calories.toInt()
    //    }

    val sumCalories = data.sumByDouble { it.calories }
    println("A soma de caloris é: $sumCalories")
    //    listOf(1,3,5,3,2).sum()



    // Me dê as duas primeiras receitas!
    val firstTwo = data.take(2)
    for(x in firstTwo.withIndex()){
        println("${x.index + 1} - ${x.value.name}")
    }

    // Sei como fazer panqueca? E sushi?
    val knowPancake = data.filter{it.name == "Panqueca"}.any()
    println("Sei fazer panqueca? ${if (knowPancake) "sim" else "não"}")
    val knowSushi = data.filter{it.name == "Sushi"}.any()
    println("Sei fazer sushi? ${if (knowPancake) "sim" else "não"}")

    // Quais são as comidas com mais de 500 calorias?
    val more500 = data.filter{it.calories > 500}.forEach{ println(it.name)}

    // Par (chave, valor) de comidas com mais de 500 calorias (name, calories)
    data.filter { it.calories > 500}
            .map { Pair(it.name, it.calories) }
            .forEach{println("${it.first}: ${it.second} calorias.")}


    // Quais das receitas possui farinha como ingrediente?
    var result = data.filter { hasIngredient(it.ingredients, "Farinha") }.forEach{ println(it.name)}
}