package com.gft.cobranca.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
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
@RequestMapping("/")
public class LoginController {
	
	@Autowired
	private CadastroUsuarioService ur;
	
	private static final String REGISTRO_VIEW = "registro";
	
	@RequestMapping
	public String home() {
		return "Inicio";
	}
	
	@RequestMapping("/registro")
	public ModelAndView novo() {
		ModelAndView mv = new ModelAndView(REGISTRO_VIEW);
		mv.addObject(new Usuario());
		return mv;
	}
	
	@RequestMapping(method = RequestMethod.POST, value = "/registro")
	public String salvar(@Validated Usuario usuario, Errors errors, RedirectAttributes attributes) {
		if (errors.hasErrors()) {
			return "registro";
		}
			usuario.setSenha(new BCryptPasswordEncoder().encode(usuario.getSenha()));
			ur.salvar(usuario);
			attributes.addFlashAttribute("mensagem", "salvo com sucesso!");
			return "redirect:/registro";
	}

	
	@RequestMapping("/login")
	public String entrar() {
		return "login";
	}
}
