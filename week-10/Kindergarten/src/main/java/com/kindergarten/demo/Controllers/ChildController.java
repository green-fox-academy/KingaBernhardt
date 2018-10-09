package com.kindergarten.demo.Controllers;

import com.kindergarten.demo.Models.Child;
import com.kindergarten.demo.Services.ChildService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class ChildController {
  private ChildService childService;

  @Autowired
  public ChildController(ChildService childService) {
    this.childService = childService;
  }

  @GetMapping("/list")
  public String list(Model model) {
    model.addAttribute("children", childService.getAllChildren());
    return "List";
  }

  @GetMapping("/add")
  public String add() {
    return "Add";
  }

  @PostMapping("/add")
  public String add(Child child) {
    childService.addNewChild(child);
    return "redirect:/";
  }

  @GetMapping("/{id}/delete")
  public String delete(@PathVariable(value = "id") Long id) {
    childService.deleteChildById(id);
    return "redirect:/";
  }

  @GetMapping("/{id}/edit")
  public String edit(@PathVariable(value = "id") Long id, Model model) {
    model.addAttribute("aChild", childService.getChildById(id));
    return "Edit";
  }

  @PostMapping("/{id}/edit")
  public String edit(@PathVariable(value = "id") Long id, @ModelAttribute Child child) {
    childService.addNewChild(child);
    return "redirect:/";
  }
}
