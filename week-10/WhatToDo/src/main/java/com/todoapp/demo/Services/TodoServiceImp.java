package com.todoapp.demo.Services;

import com.todoapp.demo.Models.Todo;
import com.todoapp.demo.Repositories.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TodoServiceImp implements TodoService {

  @Autowired
  private TodoRepository todoRepository;

  public List getListOfTodos() {
    return todoRepository.findAll();
  }

  @Override
  public List<Todo> getByTitle(String title) {
    return todoRepository.findAllByTitle(title);
  }

  @Override
  public Todo AddTodo(Todo todo) {
    return todoRepository.save(todo);
  }

  @Override
  public void deleteById(Long id) {
    todoRepository.deleteById(id);
  }

  @Override
  public Todo findById(long id) {
    return todoRepository.findById(id).get();
  }


}
