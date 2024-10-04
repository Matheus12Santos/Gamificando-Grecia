package br.com.gamificandoomundo.gamificandogrecia.services;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Cartas;
import br.com.gamificandoomundo.gamificandogrecia.repositorys.CartasRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;
import java.util.OptionalInt;

@Service
public class CartasService {
    @Autowired
    private CartasRepository repository;

    public List<Cartas> listar_cartas(){
        return repository.findAll();
    }

    public Optional<Cartas> listarCartasPorId(int id){
        return repository.findById(id);
    }

    public Cartas cadastrar_cartas(Cartas carta){
        return repository.save(carta);
    }


}
