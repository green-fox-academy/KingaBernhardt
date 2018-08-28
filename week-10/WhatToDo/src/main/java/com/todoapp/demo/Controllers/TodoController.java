package com.todoapp.demo.Controllers;

import com.todoapp.demo.Models.Todo;
import com.todoapp.demo.Services.TodoService;
import com.todoapp.demo.Services.TodoServiceImp;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping("/todo")
public class TodoController {

  @Autowired
  private TodoService todoService;

  @GetMapping(value = {"/list", "/"})
  @ResponseBody
  public String list(Model model) {
    model.addAttribute("todos", todoService.getListOfTodos());
    return "Index";
  }

  @PostMapping("/add")
  public String addTodo(@ModelAttribute Todo todo) {
    todoService.AddTodo(todo);
    return "Add";
  }

  @GetMapping("/{id}/delete")
  public String deleteTodo(@PathVariable(value = "id") Long id) {
    todoService.deleteById(id);
    return "Index";
  }

  @GetMapping("/{id}/edit")
  public String editTodo(@PathVariable(value = "id") long id, Model model) {
    model.addAttribute("todo", todoService.findById(id));
    return "Edit";
  }

  @PostMapping("/{id}/edit")
  public String editTodo(@ModelAttribute Todo todo) {
    todoService.AddTodo(todo);
    return "Index";
  }

  public String getByTitle(@RequestParam(value = "title") String title, Model model) {
    model.addAttribute("todos", todoService.getByTitle(title));
    return "Index";
  }
}
