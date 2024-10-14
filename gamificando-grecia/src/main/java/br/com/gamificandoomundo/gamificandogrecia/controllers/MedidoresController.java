package br.com.gamificandoomundo.gamificandogrecia.controllers;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Medidores;
import br.com.gamificandoomundo.gamificandogrecia.services.MedidoresService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import java.util.List;

@RestController
@RequestMapping("/medidores")
public class MedidoresController {
    @Autowired
    private MedidoresService service;

    @GetMapping
    public List<Medidores> listar_medidores(){
        return service.listar_medidores();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Medidores> listarMedidoresPorId(@PathVariable int id){
        var existe = service.listarMedidoresPorId(id);
        if(!existe.isEmpty()){
            return ResponseEntity.ok(existe.get());
        }else{
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
        //(outra maneira) return service.buscarPorId(id).map(e->ResponseEntity.ok(e)).orElse(ResponseEntity.notFound().build());
    }
    @PostMapping
    public Medidores cadastrar_medidores(@RequestBody  Medidores medidor){
        return service.cadastrar_medidores(medidor);
    }
}
