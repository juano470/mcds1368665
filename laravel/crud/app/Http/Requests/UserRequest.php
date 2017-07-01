<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class UserRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array
     */
    public function rules()
    {
        return [
            'name'=>'required|min:6',
            'email'=>'required|email',
            'password'=>'required|min:6',
            'rol'=>'required',
            'photo'=>'required|image'
        ];
    }

    public function messages()
    {
        return [
            'name.required' => 'El campo Nombre Completo es requerido.',
            'name.min' => 'El campo Nombre Completo debe tener al menos 6 caracteres.',
            'email.required'=> 'El campo Correo Electronico es requerido.',
            'password.required'=> 'El campo Contraseña es requerido.',
            'password.min'=> 'El campo Contraseña debe tener al menos 6 caracteres.',
            'rol.required'=> 'El campo Rol es requerido.',
            'photo.required'=> 'El campo Foto es requerido.'
            'photo.min'=> 'El campo Foto debe ser una imagen.'
        ];
    }

}
