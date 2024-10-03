package br.com.gamificandoomundo.gamificandogrecia.controllers;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Cartas;
import br.com.gamificandoomundo.gamificandogrecia.services.CartasService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import java.util.List;

@RestController
@RequestMapping("/cartas")
public class CartasController {
    @Autowired
    private CartasService service;

    @GetMapping
    public List<Cartas> listar_cartas(){
        return service.listar_cartas();
    }
    @PostMapping
    public Cartas cadastrar_cartas(@RequestBody Cartas carta){
        return service.cadastrar_cartas(carta);

    }

}
