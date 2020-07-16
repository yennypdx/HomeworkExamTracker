import axios from 'axios';

export const GET_ALL_TEACHER_REQUEST = 'GET_ALL_TEACHER_REQUEST';
export const GET_ALL_TEACHER_SUCCESS = 'GET_ALL_TEACHER_SUCCESS';
export const GET_ALL_TEACHER_ERROR = 'GET_ALL_TEACHER_ERROR';

const getTeacherSuccess = payload => ({
    type: GET_ALL_TEACHER_SUCCESS,
    payload
});

const getTeacherError = payload => ({
    type: GET_ALL_TEACHER_ERROR,
    payload
});

export const getAllSubject = () => dispatch => {
    dispatch({type: GET_ALL_TEACHER_REQUEST});

    return axios.get('api/Teacher/get/teachers').then(resp => {
        const response = resp.data;
        dispatch(getTeacherSuccess(response));

    }).catch(error => {
        dispatch(getTeacherError("Something went wrong!"));
        return Promise.reject({});
    })
}