package br.com.gamificandoomundo.gamificandogrecia.entitys;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
@Table(name = "Cartas")
public class Cartas {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "cartasId")
    private int cartasId;

    @Column(name = "texto")
    private String texto;

    @Column(name = "estatisticas")
    private int estatisticas;

    @ManyToOne
    @JoinColumn(name = "medidoresId")
    private Medidores medidoresId;


}
