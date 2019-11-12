import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-profile-editor',
  templateUrl: './profile-editor.component.html',
  styleUrls: ['./profile-editor.component.css']
})
export class ProfileEditorComponent {
  

  // profileForm  = new FormGroup({
  //  firstName: new FormControl(''),
  // lastName: new FormControl(''),
  //   address: new FormGroup({
  //  street: new FormControl(''), 
  //      city: new FormControl(''),
  //  state: new FormControl(''),
  //    zip: new FormControl('')
  //  })
  // });
   
//   profileform = this.fb.group({
//    firstName: [''],
//    lastName: [''],
//   address: this.fb.group({
//     street: [''],
//      city: [''],
//     state: [''],
//      zip: ['']
//   }),
//  });

profileForm = this.fb.group({
  firstName: ['', Validators.required],
  lastName: [''],
  address: this.fb.group({
    street: [''],
    city: [''],
    state: [''],
    zip: ['']
  }),
  aliases: this.fb.array([
    this.fb.control('')
  ])
});
  
get aliases() {
  return this.profileForm.get('aliases') as FormArray;
}


constructor(private fb: FormBuilder) {}


  
 

  
  updateProfile() {
    this.profileForm.patchValue({
      firstName: 'Nancy',
      address: {
        street: '123 Drew Street'
      }
    });
  }
  addAlias() {
    this.aliases.push(this.fb.control(''));
  }
    

  onSubmit() {
    // Use EventEmitter with form value
    console.warn(this.profileForm.value);
  }
  
}
