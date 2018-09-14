package com.kindergarten.demo.Models;

import com.sun.xml.internal.ws.api.ha.StickyFeature;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.web.bind.annotation.GetMapping;

import javax.persistence.*;

@Entity
@NoArgsConstructor
@Getter
@Setter
public class Address {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String city;
  private String street;
  private String zipCode;

  @OneToOne
  private Parent parent;

  public Address(Long id, String city, String street, String zipCode, Parent parent) {
    this.id = id;
    this.city = city;
    this.street = street;
    this.zipCode = zipCode;
    this.parent = parent;
  }
}
