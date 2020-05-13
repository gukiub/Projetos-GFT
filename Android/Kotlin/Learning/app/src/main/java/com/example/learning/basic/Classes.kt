class Maquina(var marca: String) {

    var nucleos: Int = 0
        get() {
            println("Get foi chamado")
            return field
        }
        set(value) {
            println("set foi chamado")
            field = value
        }

    fun ligar() {
    }

    fun processar() {
    }

    fun desligar() {
    }

}

fun main() {
    var m = Maquina("xpto")

    with(m){
        ligar()
        desligar()
        processar()
    }

    m.ligar()
    m.processar()
    m.desligar()

}