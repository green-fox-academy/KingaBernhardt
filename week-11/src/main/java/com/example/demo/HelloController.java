package com.example.demo;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

import javax.servlet.http.HttpServletRequest;

@Controller
public class HelloController {
  @GetMapping
  public String helloForm(){
    return "helloworld";
  }

  @PostMapping
  public String hello(HttpServletRequest request, Model model){
  String name =  request.getParameter("name");
  if (name == null || name == ""){
    name = "world";
  }

  model.addAttribute("name", name);
  model.addAttribute("title","greenFoxAcademy");
  return "hello";
  }
}
