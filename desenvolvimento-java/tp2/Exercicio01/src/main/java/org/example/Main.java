package org.example;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o seu nome completo: ");
        String nome = sc.nextLine().replaceAll(" ", "");

        System.out.print("Digite a sua idade: ");
        int idade = sc.nextInt();
        sc.nextLine();

        System.out.print("Digite o nome de sua mãe: ");
        String nomeMae = sc.nextLine().replaceAll(" ", "");

        System.out.print("Digite o nome de seu pai: ");
        String nomePai = sc.nextLine().replaceAll(" ", "");

        System.out.printf("%nVocê tem %d anos,%n", idade);
        if(nome.length() > nomeMae.length()){
            System.out.print("Seu nome é MAIOR que o de sua mãe e ");
        } else if(nome.length() < nomeMae.length()){
            System.out.print("Seu nome é MENOR que o de sua mãe e ");
        } else{
            System.out.print("Seu nome tem o MESMO tamanho que o nome de sua mãe e ");
        }

        if(nome.length() > nomePai.length()){
            System.out.println("É MAIOR que o de seu pai.");
        } else if(nome.length() < nomePai.length()){
            System.out.println("É MENOR que o de seu pai.");
        } else{
            System.out.println("Tem o MESMO tamanho que o nome de seu pai.");
        }
    }
}