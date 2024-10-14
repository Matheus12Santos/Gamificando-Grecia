package br.com.gamificandoomundo.gamificandogrecia.services;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Personagens;
import br.com.gamificandoomundo.gamificandogrecia.repositorys.PersonagensRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class PersonagensService {
    @Autowired
    private PersonagensRepository repository;

    public List<Personagens> listar_cartas(){
        return repository.findAll();
    }

    public Optional<Personagens> listarCartasPorId(int id){
        return repository.findById(id);
    }

    public Personagens cadastrar_cartas(Personagens carta){
        return repository.save(carta);
    }


}
