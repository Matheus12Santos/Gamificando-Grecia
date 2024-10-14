package br.com.gamificandoomundo.gamificandogrecia.entitys;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
@Table(name = "Personagens")
public class Personagens {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "PersonId")
    private int personId;

    @Column(name = "PersonName")
    private String personName;

    @Column(name = "PersonTexto")
    private String personTexto;

    @Column(name = "PersonOpc1")
    private String personOpc1;

    @Column(name = "PersonOpc2")
    private String personOpc2;
}
