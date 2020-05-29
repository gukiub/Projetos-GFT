package com.example.exerciciolinearlayoutcheckboxeimageview

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    fun isChecked(view: View) {
        if(checkBox.isChecked){
            imageView.setColorFilter(resources.getColor(R.color.vermelho))
        } else{
            imageView.setColorFilter(resources.getColor(R.color.black))
        }
    }
}
