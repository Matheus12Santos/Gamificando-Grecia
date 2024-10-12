package br.com.gamificandoomundo.gamificandogrecia.entitys;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
@Table(name = "Personagem")
public class Personagem {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "personagemId")
    private int id;
    @Column(name = "nome")
    private String nome;
}
