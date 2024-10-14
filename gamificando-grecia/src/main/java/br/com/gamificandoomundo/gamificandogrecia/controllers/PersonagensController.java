package br.com.gamificandoomundo.gamificandogrecia.controllers;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Personagens;
import br.com.gamificandoomundo.gamificandogrecia.services.PersonagensService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import java.util.List;

@RestController
@RequestMapping("/cartas")
public class PersonagensController {
    @Autowired
    private PersonagensService service;

    @GetMapping
    public List<Personagens> listar_cartas(){
        return service.listar_cartas();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Personagens> listarCartasPorId(@PathVariable int id){
        var existe = service.listarCartasPorId(id);
        if(!existe.isEmpty()){
            return ResponseEntity.ok(existe.get());
        }else{
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
        //(outra maneira) return service.buscarPorId(id).map(e->ResponseEntity.ok(e)).orElse(ResponseEntity.notFound().build());
    }
    @PostMapping
    public Personagens cadastrar_cartas(@RequestBody Personagens carta){
        return service.cadastrar_cartas(carta);

    }

}
