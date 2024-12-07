package com.example.laboratorio5;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    ListView lstEnfermedad;
    List<Enfermedad> lst;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lstEnfermedad = findViewById(R.id.listEnf);
        Adaptador adaptador = new Adaptador(this, GetData());
        lstEnfermedad.setAdapter(adaptador);

        lstEnfermedad.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Enfermedad e = lst.get(i);
                Toast.makeText(getBaseContext(), e.nombre,Toast.LENGTH_SHORT).show();
            }
        });
    }

    private List<Enfermedad> GetData() {
        lst = new ArrayList<>();
        lst.add(new Enfermedad(1,R.drawable.asbestos, "Asbesto", "Causada por una inflamación constante en las vías respiratorias. Algunos síntomas incluyen espasmos pulmonares, sibilancias y falta de respiración."));
        lst.add(new Enfermedad(2, R.drawable.asma, "Asma", "Enfermedad pulmonar crónica causada por la inhalación de fibras de asbesto. La exposición prolongada a estas fibras puede causar cicatrización del tejido pulmonar y falta de aire."));
        lst.add(new Enfermedad(3, R.drawable.bronquitis, "Bronquitis", "La membrana mucosa que protege a los pulmones se inflama en el pasaje bronquial. Esto causa hinchazón que impide el paso del aire a los pulmones."));
        lst.add(new Enfermedad(4, R.drawable.cancer, "Cáncer Pulmonar", "El factor principal es el tabaco, pero también puede ser provocado por sustancias químicas y la contaminación ambiental."));
        lst.add(new Enfermedad(5, R.drawable.enfisema, "Enfisema", "Acumulación de aire en los tejidos u órganos del cuerpo, evoluciona lentamente conforme pasan los años y no tiene cura."));
        lst.add(new Enfermedad(6, R.drawable.neumonia, "Neumonía", "Causada por una infección en los sacos pulmonares. La infección puede ser causada por una bacteria, un virus u hongo."));
        lst.add(new Enfermedad(7, R.drawable.rinosinusitis, "Rinosinusitis", "Dolor en la zona de la frente, ojos y nariz, malestar general, fiebre, secreción nasal"));
        lst.add(new Enfermedad(8, R.drawable.tuberculosis, "Tuberculosis", "La bacteria que causa la tuberculosis se contagia de persona a persona a través de pequeñas gotitas diseminadas en el aire al toser o estornudar."));

        return lst;
    }
}