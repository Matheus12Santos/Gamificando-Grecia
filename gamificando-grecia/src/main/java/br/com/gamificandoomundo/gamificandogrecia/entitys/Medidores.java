package br.com.gamificandoomundo.gamificandogrecia.entitys;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Entity
@Getter
@Setter
@Table(name = "Medidores" )
public class Medidores {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "medidoresId")
    private int medidoresId;

    @Column(name = "estatisticas")
    private int estatisticas;

}
