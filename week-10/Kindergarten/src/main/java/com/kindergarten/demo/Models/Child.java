package com.kindergarten.demo.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.NegativeOrZero;
import java.util.ArrayList;
import java.util.List;

@Entity
@NoArgsConstructor
@Getter
@Setter
public class Child {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String name;
  private String birthdate;
  private String sign;
  @OneToOne
  private Group group;
  
  @OneToMany
  private List<Teacher> teachers = new ArrayList<>();
  
  public Child(String name, String birthdate, String sign) {
    this.name = name;
    this.birthdate = birthdate;
    this.sign = sign;
  }
}
