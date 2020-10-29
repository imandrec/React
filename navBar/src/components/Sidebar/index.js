import React from 'react';
import { SidebarContainer, Icon, CloseIcon, SidebarWrapper, SidebarMenu, SidebarLink, SideBtnWrap, SidebarRoute} from './SidebarElements';

const Sidebar = ({ isOpen, toggle }) => {
    return (
        <SidebarContainer isOpen={isOpen} onClick={toggle}>
            <Icon onClick={toggle}>
                <CloseIcon />
            </Icon>   
            <SidebarWrapper>
                <SidebarMenu>
                     <SidebarLink to ='home'>
                         Home
                     </SidebarLink>
                     <SidebarLink to ='services'>
                         Services
                     </SidebarLink>
                     <SidebarLink to ='aboutus'>
                         About Us
                     </SidebarLink>
                </SidebarMenu>
                <SideBtnWrap>
                    <SidebarRoute to='/contact'>
                        Contact
                    </SidebarRoute>
                </SideBtnWrap>
            </SidebarWrapper>
        </SidebarContainer>
    );
};

export default Sidebar;
