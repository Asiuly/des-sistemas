import 'package:flutter/material.dart';
import 'dart:io';

var corPadrao = Colors.red;
TextEditingController txtNota1 = TextEditingController();
TextEditingController txtNota2 = TextEditingController();
TextEditingController txtNota3 = TextEditingController();
TextEditingController txtResultado = TextEditingController();

void main() {
  runApp(MaterialApp(
    title: 'Meu Primeiro Aplicativo',
    home:
    Scaffold(
      appBar: AppBar(
      leading: const Icon(Icons.home),
      title: const Text('Calculo de Médias'),      
      actions: const [Icon(Icons.favorite)],
      backgroundColor: corPadrao),

      body:Padding(
            padding: const EdgeInsets.symmetric(horizontal: 17.0),

            child: Column(
              children: [
                const SizedBox(height: 20.0),

                TextField(controller: txtNota1, 
                  decoration: const InputDecoration(
                      prefixIcon: Icon(Icons.login),
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(3)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 102, 19, 70), width: 1.0)
                    ),
                        focusedBorder: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(15)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 65, 20, 73), width: 2.0)
                      ),
                      filled: true,
                        fillColor: Color.fromARGB(255, 239, 224, 245),
                      labelText: "Insira sua primeira nota",
                      hintText: "Primeira Nota.",
              )),

                const SizedBox(height: 20.0),

                TextField(controller: txtNota2, 
                  decoration: const InputDecoration(
                      prefixIcon: Icon(Icons.login),
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(3)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 102, 19, 70), width: 1.0)
                    ),
                        focusedBorder: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(15)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 65, 20, 73), width: 2.0)
                      ),
                      filled: true,
                        fillColor: Color.fromARGB(255, 239, 224, 245),
                      labelText: "Insira sua segunda nota",
                      hintText: "Segunda Nota.",
              )),

                const SizedBox(height: 20.0),

                TextField(controller: txtNota3, 
                  decoration: const InputDecoration(
                      prefixIcon: Icon(Icons.login),
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(3)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 102, 19, 70), width: 1.0)
                    ),
                        focusedBorder: OutlineInputBorder(
                        borderRadius: BorderRadius.all(Radius.circular(15)),
                        borderSide: BorderSide(color: Color.fromARGB(255, 65, 20, 73), width: 2.0)
                      ),
                      filled: true,
                        fillColor: Color.fromARGB(255, 239, 224, 245),
                      labelText: "Insira sua terceira nota",
                      hintText: "Terceira Nota.",
              )),

                 const SizedBox(height: 25.0),

                 Row(
                    children: [
                      ElevatedButton(
                        onPressed: () => calcularMedia(),

                        style: ElevatedButton.styleFrom(
                          primary: const Color.fromARGB(255, 196, 101, 101),
                          minimumSize: const Size(160, 50)),

                        child: const Text('Média'),
                                    ),

                       const SizedBox(width: 35.0),

                      ElevatedButton(
                        onPressed: () => limparTexts(),

                        style: ElevatedButton.styleFrom(
                          primary: const Color.fromARGB(255, 196, 101, 101),
                          minimumSize: const Size(160, 50)),

                        child: const Text('Limpar'),
                                    ),
                             ],
                      ),

                      const SizedBox(height: 25.0),

                      TextField(controller: txtResultado, 
                                enabled: false,
                        decoration: const InputDecoration(
                            prefixIcon: Icon(Icons.lock),
                            border: OutlineInputBorder(
                              borderRadius: BorderRadius.all(Radius.circular(3)),
                              borderSide: BorderSide(color: Color.fromARGB(255, 102, 19, 70), width: 1.0)
                          ),
                              focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.all(Radius.circular(15)),
                              borderSide: BorderSide(color: Color.fromARGB(255, 133, 67, 145), width: 2.0)
                            ),
                            filled: true,
                              fillColor: Color.fromARGB(255, 240, 238, 241),
                            labelText: "Resultado da Média",
            )),

                      const SizedBox(height: 20.0),

                      ElevatedButton(
                        onPressed: () => exit(0),

                        style: ElevatedButton.styleFrom(
                          primary: const Color.fromARGB(255, 196, 101, 101),
                          minimumSize: const Size(265, 50)),

                        child: const Text('FECHAR'),
                                    ),

                        ], //children
                        
                        ))
      )
   ));
}

calcularMedia() 
{
  int n1 = int.parse(txtNota1.text);
  int n2 = int.parse(txtNota2.text);
  int n3 = int.parse(txtNota3.text);

  double media = (n1+n2+n3)/3;

  txtResultado.text = media.toString();
}

limparTexts()
{
  txtNota1.clear();
  txtNota2.clear();
  txtNota3.clear();
  txtResultado.clear();
}