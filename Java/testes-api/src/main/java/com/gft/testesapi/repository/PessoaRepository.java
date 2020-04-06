package com.gft.testesapi.repository;


import org.springframework.data.jpa.repository.JpaRepository;

import com.gft.testesapi.model.Pessoa;

public interface PessoaRepository extends JpaRepository<Pessoa, Long>{

}
