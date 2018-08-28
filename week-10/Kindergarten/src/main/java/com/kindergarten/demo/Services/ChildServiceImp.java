package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Child;
import com.kindergarten.demo.Repositories.ChildRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class ChildServiceImp implements ChildService {

  private ChildRepository childRepository;

  @Autowired
  public ChildServiceImp(ChildRepository childRepository) {
    this.childRepository = childRepository;
  }

  @Override
  public List<Child> getAllChildren() {
    List<Child> children = new ArrayList<>();
    childRepository.findAll().forEach(children::add);
    return children;
  }

  @Override
  public void addNewChild(Child child) {
    childRepository.save(child);
  }

  @Override
  public void deleteChildById(Long id) {
    childRepository.deleteById(id);
  }

  @Override
  public Child getChildById(Long id) {
    return childRepository.findById(id).get();
  }

}