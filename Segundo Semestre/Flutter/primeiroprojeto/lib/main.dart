import 'package:flutter/material.dart';

var corPadrao = Colors.red;

void main() {
  runApp(MaterialApp(
    title: 'Meu Primeiro Aplicativo',
    home:
    Scaffold(
      appBar: AppBar(
      leading: const Icon(Icons.home),
      title: const Text('Barra do APP'), 
      actions: const [Icon(Icons.favorite),
                      Icon(Icons.photo_camera)],
      backgroundColor: corPadrao),
      body:
            const Center( widthFactor: 6, heightFactor: 5,
              child: Text("delicia"),
            )
            
      )
   ));
}