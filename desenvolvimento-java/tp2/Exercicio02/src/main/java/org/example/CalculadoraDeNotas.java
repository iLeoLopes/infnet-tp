package org.example;

public class CalculadoraDeNotas {
    private double b1;
    private double b2;
    private double b3;
    private double b4;
    private String resultado;

    public CalculadoraDeNotas(double b1, double b2, double b3, double b4) {
        this.b1 = b1;
        this.b2 = b2;
        this.b3 = b3;
        this.b4 = b4;
    }
    public String calculaMedia() {
        double media = (b1 + b2 + b3 + b4) / 4;
        if (media >= 7) {
            resultado = "Aprovado";
        } else if (media >= 5.0){
            resultado = "Recuperação";
        } else {
            resultado = "Reprovado";
        }
        return media + " -> " + resultado;
    }

    @Override
    public String toString() {
        return  "Média do aluno: " + calculaMedia();
    }
}
