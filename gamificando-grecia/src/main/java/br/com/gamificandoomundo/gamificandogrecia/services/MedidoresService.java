package br.com.gamificandoomundo.gamificandogrecia.services;

import br.com.gamificandoomundo.gamificandogrecia.entitys.Medidores;
import br.com.gamificandoomundo.gamificandogrecia.repositorys.MedidoresRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class MedidoresService {
    @Autowired
    private MedidoresRepository repository;

    public List<Medidores> listar_medidores(){
        return repository.findAll();
    }

    public Optional<Medidores> listarMedidoresPorId(int id){
        return repository.findById(id);
    }

    public Medidores cadastrar_medidores(Medidores medidor){
        return repository.save(medidor);
    }

}
