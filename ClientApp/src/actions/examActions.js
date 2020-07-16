import axios from 'axios';

export const GET_ALL_EXAM_REQUEST = 'GET_ALL_EXAM_REQUEST';
export const GET_ALL_EXAM_SUCCESS = 'GET_ALL_EXAM_SUCCESS';
export const GET_ALL_EXAM_ERROR = 'GET_ALL_EXAM_ERROR';

const getExamSuccess = payload => ({
    type: GET_ALL_EXAM_SUCCESS,
    payload
});

const getExamError = payload => ({
    type: GET_ALL_EXAM_ERROR,
    payload
});

export const getAllExam = () => dispatch => {
    dispatch({type: GET_ALL_EXAM_REQUEST});

    return axios.get('api/Exam/get/examllist/{id}').then(resp => {
        const response = resp.data;
        dispatch(getExamSuccess(response));

    }).catch(error => {
        dispatch(getExamError("Something went wrong!"));
        return Promise.reject({});
    })
}