package com.gft.socialbooks.domain;

import java.util.Date;
import java.util.List;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonInclude.Include;

import io.swagger.annotations.ApiModelProperty;

//@ApiModel(value = "Autores", description = "Representa um autor")
@Entity
public class Autor {
	
	@ApiModelProperty(example = "1")
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	@ApiModelProperty(example = "Lucas")
	@JsonInclude(Include.NON_NULL)
	@NotEmpty(message = "O autor deve possuir um nome")
	private String nome;
	
	@ApiModelProperty(example = "20/10/2000")
	@JsonInclude(Include.NON_NULL)
	@JsonFormat(pattern = "dd/MM/yyyy")
	@NotNull(message = "a data de nascimento é obrigatória")
	private Date nascimento;
	
	@ApiModelProperty(example = "Brazilian")
	@JsonInclude(Include.NON_NULL)
	@NotNull(message = "nacionalidade é obrigatória")
	private String nacionalidade;
	
	@OneToMany(mappedBy = "autor")
	@JsonIgnore
	private List<Livro> livros;
	public Long getId() {
		return id;
	}
	public void setId(Long id) {
		this.id = id;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public Date getNascimento() {
		return nascimento;
	}
	public void setNascimento(Date nascimento) {
		this.nascimento = nascimento;
	}
	public String getNacionalidade() {
		return nacionalidade;
	}
	public void setNacionalidade(String nacionalidade) {
		this.nacionalidade = nacionalidade;
	}
	public List<Livro> getLivros() {
		return livros;
	}
	public void setLivros(List<Livro> livros) {
		this.livros = livros;
	}
	
	
}
