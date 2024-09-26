@Entity
@Getter
@Setter
@Table(name = "Cartas")
public class Cartas{

@ID
@GeneratedValue(strategy.)
@Column("cartasId")
private int cartasId,
@Column("texto")
private texto String,
@column("estatisticas")
private estatisticas int,

@JoinColumn("medidoresId")
private Medidores medidoresId


}