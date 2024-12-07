package com.example.laboratorio5;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.List;

public class Adaptador extends BaseAdapter {

    Context context;
    List<Enfermedad> lst;


    public Adaptador(Context context, List<Enfermedad> lst) {
        this.context = context;
        this.lst = lst;
    }

    @Override
    public int getCount() {
        return lst.size();
    }

    @Override
    public Object getItem(int i) {
        return i;
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        ImageView imgEnfer;
        TextView txtNombre;
        TextView txtDes;

        Enfermedad e = lst.get(i);

        if (view==null)
            view = LayoutInflater.from(context).inflate(R.layout.listview, null);

        imgEnfer = view.findViewById(R.id.imageVirus);
        txtNombre = view.findViewById(R.id.txtNombre);
        txtDes = view.findViewById(R.id.txtDesc);

        imgEnfer.setImageResource(e.imagen);
        txtNombre.setText(e.nombre);
        txtDes.setText(e.Descripcion);

        return view;
    }
}
