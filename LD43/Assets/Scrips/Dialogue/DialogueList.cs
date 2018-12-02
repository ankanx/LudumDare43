using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueList : MonoBehaviour {

    public List<List<string>> listOfPlayerToGoblin = new List<List<string>>();
    public List<List<string>> listOfGoblinToPlayer = new List<List<string>>();
    public List<List<string>> listOfGoblinToGoblin = new List<List<string>>();
    public List<List<string>> listOfCheckpoint = new List<List<string>>();
    public List<List<string>> listOfBigGoblinToPlayer = new List<List<string>>();

    private void Start()
    {

        List<string> playerToGoblin1 = new List<string> {
        "¡Hola! ¿Qué tal?" };

        List<string> playerToGoblin2 = new List<string> {
        "No me descargaré nada de Goblintorrent.com, me lo voy a ganar." };

        List<string> playerToGoblin3 = new List<string> {
        "¡Fuera, fuera!" };

        List<string> playerToGoblin4 = new List<string> {
        "¡Oye!Me ha costado mucho conseguir esto, gánatelo y no me lo robes" };

        listOfPlayerToGoblin.Add(playerToGoblin1);
        listOfPlayerToGoblin.Add(playerToGoblin2);
        listOfPlayerToGoblin.Add(playerToGoblin3);
        listOfPlayerToGoblin.Add(playerToGoblin4);


        List<string> goblinToPlayer1 = new List<string> {
        "Uuhhhhh, me gusta tu ropa, donde la conseguiste?"};

        List<string> goblinToPlayer2 = new List<string> {
        "ega ega ega todo está en mega"};

        List<string> goblinToPlayer3 = new List<string> {
        "Taringa" };

        List<string> goblinToPlayer4 = new List<string> {
        "Desactiva el adblock que si no le podemos robar"};

        List<string> goblinToPlayer5 = new List<string> {
        "Goblindede se ha caído otra vez. ¡Déjame ver lo que llevas!"};

        listOfGoblinToPlayer.Add(goblinToPlayer1);
        listOfGoblinToPlayer.Add(goblinToPlayer2);
        listOfGoblinToPlayer.Add(goblinToPlayer3);
        listOfGoblinToPlayer.Add(goblinToPlayer4);
        listOfGoblinToPlayer.Add(goblinToPlayer5);

        List<string> goblinToGoblin1 = new List<string> {
        "Uuhhhhh, me gusta tu ropa, donde la conseguiste?" };

        List<string> goblinToGoblin2 = new List<string> {
        "¿Has visto al nueva armadura del jugador?"};

        List<string> goblinToGoblin3 = new List<string> {
        "Me descargué esto en goblintorrent.com"};

        List<string> goblinToGoblin4 = new List<string> {
        "Desactiva el adblock que si no le podemos robar"};

        List<string> goblinToGoblin5 = new List<string> {
        "Le descargué a mi madre un bolso de glucci a mi mama."};



        listOfGoblinToGoblin.Add(goblinToGoblin1);
        listOfGoblinToGoblin.Add(goblinToGoblin2);
        listOfGoblinToGoblin.Add(goblinToGoblin3);
        listOfGoblinToGoblin.Add(goblinToGoblin4);
        listOfGoblinToGoblin.Add(goblinToGoblin5);

        List<string> checkpointy = new List<string> {
        "Soy un punto de guardado, si me visitas, te recordaré"};

        listOfCheckpoint.Add(checkpointy);


        List<string> boss1 = new List<string> {
        "Hola, soy el jefe goblintorrent.com",
        "¿Vienes a destruirme para que que se caiga mi web?",
        "¡No tienes nada que hacer! JAJAJAJAJAJA",
        "¿Pero tú quién te has creído que eres, pequeño humano?"};

        List<string> boss2 = new List<string> {
        "Hola, soy el jefe goblintorrent.com",
        "¿Vienes a destruirme para que que se caiga mi web?",
        "¿No serás tú un comepiedras volador? JAJAJAJA que gracioso soy."};

        List<string> boss3 = new List<string> {
        "Hola, soy el jefe goblintorrent.com",
        "¿Vienes a destruirme para que que se caiga mi web?",
        "Dale like para más juegos gratis."};

        List<string> boss4 = new List<string> {
        "Hola, soy el jefe goblintorrent.com",
        "¿Vienes a destruirme para que que se caiga mi web?",
        "Suscríbete a nuestro premium en goblintorrent.com para una descarga más rápida"};

        listOfBigGoblinToPlayer.Add(boss1);
        listOfBigGoblinToPlayer.Add(boss2);
        listOfBigGoblinToPlayer.Add(boss3);
        listOfBigGoblinToPlayer.Add(boss4);
    }

    





}
