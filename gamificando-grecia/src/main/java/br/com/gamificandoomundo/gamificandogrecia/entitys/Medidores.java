package br.com.gamificandoomundo.gamificandogrecia.entitys;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
@Table(name = "Medidores")
public class Medidores {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "MedidorId")
    private int medidorId;

    @ManyToOne
    @JoinColumn(name = "PersonId")
    private Personagens personId;

    @Column(name = "EstatisMantimentos")
    private int estatisMantimentos;

    @Column(name = "EstatisExercito")
    private int estatisExercito;

    @Column(name = "EstatisConfianca")
    private int estatisConfianca;
}
