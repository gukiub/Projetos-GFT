package com.gft.cobranca.Controller;

import org.springframework.stereotype.Controller;
import org.springframework.validation.Errors;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.gft.cobranca.model.Usuario;
import com.gft.cobranca.service.CadastroUsuarioService;

@Controller
public class LoginController {
	@RequestMapping
	public String home() {
		return "Inicio";
	}
	
	@RequestMapping("/registro")
	public ModelAndView novo() {
		ModelAndView mv = new ModelAndView("/");
		mv.addObject(new Usuario());
		return mv;
	}
	
	@RequestMapping(method = RequestMethod.POST)
	public String salvar(@Validated Usuario usuario, Errors errors, RedirectAttributes attributes) {
		if (errors.hasErrors()) {
			return "registro";
		}

		// TODO: Salvar no banco de dados
		try {
			CadastroUsuarioService.salvar(usuario);
			attributes.addFlashAttribute("mensagem", "Titulo salvo com sucesso!");
			return "redirect:/titulos/novo";
		} catch (IllegalArgumentException e) {
			errors.rejectValue("dataVencimento", null, e.getMessage());
			return CADASTRO_VIEW;
		}
	}

	
	@RequestMapping("/login")
	public String entrar() {
		return "login";
	}
}
