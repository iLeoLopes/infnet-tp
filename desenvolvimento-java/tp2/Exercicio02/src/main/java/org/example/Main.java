package org.example;

import java.util.Locale;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("A seguir digite as 4 notas do aluno: ");
        double b1 = sc.nextDouble();
        double b2 = sc.nextDouble();
        double b3 = sc.nextDouble();
        double b4 = sc.nextDouble();

        CalculadoraDeNotas calculadoraDeNotas = new CalculadoraDeNotas(b1, b2, b3, b4);
        calculadoraDeNotas.calculaMedia();
        System.out.println(calculadoraDeNotas);
    }
}
