package br.com.gamificandoomundo.gamificandogrecia.controllers;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Medidores;
import br.com.gamificandoomundo.gamificandogrecia.services.MedidoresService;
import org.springframework.beans.factory.annotation.Autowired;
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
    @PostMapping
    public Medidores cadastrar_medidores(@RequestBody  Medidores medidor){
        return service.cadastrar_medidores(medidor);
    }
}
