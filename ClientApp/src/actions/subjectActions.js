import axios from 'axios';

export const GET_ALL_SUBJECT_REQUEST = 'GET_ALL_SUBJECT_REQUEST';
export const GET_ALL_SUBJECT_SUCCESS = 'GET_ALL_SUBJECT_SUCCESS';
export const GET_ALL_SUBJECT_ERROR = 'GET_ALL_SUBJECT_ERROR';

const getSubjectSuccess = payload => ({
    type: GET_ALL_SUBJECT_SUCCESS,
    payload
});

const getSubjectError = payload => ({
    type: GET_ALL_SUBJECT_ERROR,
    payload
});

export const getAllSubject = () => dispatch => {
    dispatch({type: GET_ALL_SUBJECT_REQUEST});

    return axios.get('api/Subject/get/subjects').then(resp => {
        const response = resp.data;
        dispatch(getSubjectSuccess(response));

    }).catch(error => {
        dispatch(getSubjectError("Something went wrong!"));
        return Promise.reject({});
    })
}