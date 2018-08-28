package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Child;
//import com.kindergarten.demo.Models.Parent;
//import com.kindergarten.demo.Models.Teacher;
import com.kindergarten.demo.Repositories.ChildRepository;
import org.springframework.stereotype.Service;

import javax.swing.text.html.parser.Entity;
import java.lang.reflect.Type;
import java.util.List;

@Service
public interface ChildService {

  Iterable<Child> getAllChildren();

  void addNewChild(Child child);

  void deleteChildById(Long id);

  Child getChildById(Long id);
}
